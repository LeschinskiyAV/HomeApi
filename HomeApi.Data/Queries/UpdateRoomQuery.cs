using System;

namespace HomeApi.Data.Queries
{

    public class UpdateRoomQuery
    {

        public DateTime NewAddDate { get; }
        public string NewName { get; }
        public int NewArea { get; }
        public bool NewGasConnected { get; }
        public int NewVoltage { get; }

        public UpdateRoomQuery(DateTime newAddDate, int newArea = 0, bool newGasConnected = false, int newVoltage = 0, string newName = null)
        {
            NewAddDate = newAddDate;
            NewArea = newArea;
            NewGasConnected = newGasConnected;
            NewVoltage = newVoltage;
            NewName = newName;

        }
    }
}