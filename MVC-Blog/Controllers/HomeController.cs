﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using MVC_Blog.Models;

namespace MVC_Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var post = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(5);
            return View(post.ToList());
        }
    }
}