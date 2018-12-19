using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcApp.Controllers
{
    public class ProjectListController : Controller
    {
        // GET: ProjectList
        public ActionResult Index()
        {
            Models.ProjectItem item = new Models.ProjectItem();
            item.projectCd = "20181218-00000000001";
            item.projectName = "検証用物件";
            item.tantoName = "山田　太郎";
            item.address = "東京都千代田区神田１丁目１番地１　ビル８階";
            item.planDate = "2018/12/19";
            item.workdate = "2018/12/20";
            return View(item);
        }
    }
}