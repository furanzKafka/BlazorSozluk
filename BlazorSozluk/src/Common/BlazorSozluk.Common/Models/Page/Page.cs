﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Models.Page
{
    public class Page
    {
        public Page():this(0)
        {

        }
        public Page(int totalRowCount) : this(currentPage: 1, pageSize: 10, totalRowCount: totalRowCount)
        {
            TotalRowCount = totalRowCount;
        }

        public Page(int pageSize, int totalRowCount) : this(currentPage: 1, pageSize: pageSize, totalRowCount: totalRowCount)
        {
            PageSize = pageSize;
            TotalRowCount = totalRowCount;
        }

        public Page(int currentPage, int pageSize, int totalRowCount)
        {
            if (currentPage < 1)
                throw new ArgumentException("invalid page number");

            if (pageSize < 1)
                throw new ArgumentException("invalid page size");


            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalRowCount = totalRowCount;
        }

        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalRowCount { get; set; }
        public int TotalPageCount => (int)Math.Ceiling((double)TotalRowCount / PageSize);
        public int Skip => (CurrentPage - 1) * PageSize;
    }
}