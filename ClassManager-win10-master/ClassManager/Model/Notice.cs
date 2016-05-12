﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager.Model
{
    public class Notice
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public string join_on { get; set; }
        public string deadline { get; set; }
        public bool unlook { get; set; }
        public bool uncomplish { get; set; }
        public string image { get; set; }
		public int unlooksNum { get; set; }
		public List<User> unlooks { get; set; }
        public Notice()
        {
            _id = "";
            name = "";
            content = "";
            join_on = "";
            deadline = "";
            unlook = true;
            uncomplish = true;
            image = "";
			unlooksNum = 0;
			unlooks = new List<User>();
        }
    }
}
