﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAssignmentSimple.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PlainText { get; set; }
        public bool PinStatus { get; set; }
        public List<CheckList> CheckLists { get; set; }
        public List<Label> Labels { get; set; }
    }
}
