﻿using InventoryManagementSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Data
{
    [Table("Inventory")]
    public class Inventory : InventoryAbstract
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }

    }
}
