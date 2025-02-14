﻿using DLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
	public class WordRoomModel
	{
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public Guid WordId { get; set; }
        public WordColor? Color { get; set; }
        public string WordName { get; set; } = null!;
        public bool IsGuessed { get; set; }
    }
}
