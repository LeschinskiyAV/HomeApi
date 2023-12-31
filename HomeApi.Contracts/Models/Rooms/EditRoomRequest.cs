﻿using System;

namespace HomeApi.Contracts.Models.Rooms
{

    public class EditRoomRequest
    {
        public DateTime NewAddDate { get; set; }
        public string NewName { get; set; }
        public int NewArea { get; set; }
        public bool NewGasConnected {  get; set; }
        public int NewVoltage {  get; set; }
    }
}