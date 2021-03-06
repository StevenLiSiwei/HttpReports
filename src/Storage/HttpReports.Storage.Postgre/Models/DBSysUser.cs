﻿using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpReports.Storage.PostgreSQL.Models
{

    [Table(Name = "SysUser")]
    [Index("idx_user_id", "Id", true)]
    public class DBSysUser
    {

        [Column(IsPrimary = true, StringLength = 50)]
        public string Id { get; set; }

        [Column(StringLength = 50)] 
        public string UserName { get; set; }


        [Column(StringLength = 50)]
        public string Password { get; set; }

    }
}
