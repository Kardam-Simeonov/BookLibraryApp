﻿using System;
using System.Collections.Generic;

namespace BookLibraryApp.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
    }
}
