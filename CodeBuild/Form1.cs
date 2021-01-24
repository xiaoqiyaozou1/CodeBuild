using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeBuild
{
    public partial class Form1 : Form
    {
        //存储文件名字
        List<string> modelNames = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;

                var files = Directory.GetFiles(foldPath, "*.cs");

                foreach (var item in files)
                {
                    var fileName = Path.GetFileNameWithoutExtension(item);
                    modelNames.Add(fileName);
                }
                this.txtFileInfo.Text = foldPath;
                MessageBox.Show("已选择文件夹:" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOutputFileSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                this.txtOutputFile.Text = foldPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBoxButtons boxButtons = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("开始生成！", "提示信息", boxButtons);
            if (dr == DialogResult.OK)
            {
                var isBuildService = this.checkService.Checked;
                if (isBuildService)
                {
                    BulidIServiceCode();
                }
                //BuildControllerCode();
            }
            else
            {

            }
        }


        private void BulidIServiceCode()
        {
            var savePath = txtOutputFile.Text;
            if (!string.IsNullOrWhiteSpace(savePath))
            {
                string contollPath = savePath + "/IService/";
                if (Directory.Exists(contollPath) == false)
                {
                    Directory.CreateDirectory(contollPath);
                }

                StringBuilder sb = new StringBuilder();
                foreach (var item in modelNames)
                {
                    sb.Append(@"  public partial interface I" + item + @"Service : IBaseService<" + item + @">
     {
     }");
                }



                string str = @"using System;
using System.Collections.Generic;
using System.Text;
using XiaoQi.EFCore;
using XiaoQi.EFCore.Models;

namespace" + this.txtNameSpace.Text + @"
{
    " + sb.ToString() + @"
}";
                File.WriteAllText(contollPath + this.txtServiceName.Text, str);
            }
            else
            {
                MessageBox.Show("输出文件夹不能为空");
            }

        }

        private void BuildServiceCode()
        {

        }

        private void BuildControllerCode()
        {
            var savePath = txtOutputFile.Text;
            if (!string.IsNullOrWhiteSpace(savePath))
            {
                string contollPath = savePath + "/Controller/";
                if (Directory.Exists(contollPath) == false)
                {
                    Directory.CreateDirectory(contollPath);
                }

                StringBuilder sb = new StringBuilder();
                foreach (var item in modelNames)
                {
                    sb.Append(@"  public partial interface I" + item + @"Service : IBaseService<" + item + @">
     {
     }");
                }



                string str = @"using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XiaoQi.IService;

namespace XiaoQi.Controllers
{
    [Route("+"\"api /[controller] /[action]" + "\""+ @")]
      [ApiController]
    //[Authorize(" + "\"" + @"MyPolicy" + "\"" + @")]
    public class FmUserController : ControllerBase
        {
            private readonly IFmUserService _fmUserService;

            private readonly IUserStepsService _userStepsService;
            public FmUserController(IFmUserService userService, IUserStepsService userStepsService)
            {
                _fmUserService = userService;
                _userStepsService = userStepsService;
            }
            /// <summary>
            /// 获取所有的用户信息
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            public IActionResult GetUserInfos()
            {
                var res = _fmUserService.Query();
                return new JsonResult(res);
            }
            /// <summary>
            /// 获取所有的用户信息和相关步数
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            public IActionResult GetUserSteps()
            {
                var res = _userStepsService.GetAll();
                return new JsonResult(res);
            }
        }
    }";
                File.WriteAllText(contollPath + "test.cs", str);
            }
            else
            {
                MessageBox.Show("输出文件夹不能为空");
            }
        }
    }
}
