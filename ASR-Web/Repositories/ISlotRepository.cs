﻿using ASR_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASR_Web.Repositories
{
    public interface ISlotRepository
    {
        IEnumerable<Slot> GetAllSlots();
        IEnumerable<Slot> GetAvailibleSlots();
        IEnumerable<Slot> GetAvailibleSlotsGivenDay(DateTime day);
        IEnumerable<Slot> GetRoomSlotsGivenDay(string roomID, DateTime day);
        IEnumerable<Slot> GetFilteredSlots(string RoomSelect, string StaffSelect, string StudentSelect);

        IEnumerable<Slot> SearchByRoom(string roomID);
        IEnumerable<Slot> SearchByDate(DateTime start, DateTime end);
        IEnumerable<Slot> SearchByStaff(string  staffID);
        IEnumerable<Slot> SearchByStudent(string studentID);
        IEnumerable<Slot> SearchByStaffDate(string staffID, DateTime inputDate);
        IEnumerable<Slot> SearchByStudentDate(string studentID, DateTime inputDate);

        IEnumerable<String> GetDistinctRooms();
        IEnumerable<String> GetDistinctStaff();
        IEnumerable<String> GetDistinctStudents();

        Slot Find(string roomID, DateTime startTime);
        Slot Book(Slot slot, string studentID);
        Slot Unbook(Slot slot);
        Slot Create(Slot slot);
        Slot Update(Slot slot);
        Slot Validate(Slot slot);

        bool Delete(Slot slot);
    }
}
