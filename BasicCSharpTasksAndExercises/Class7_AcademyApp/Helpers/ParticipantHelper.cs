using System;
using Class7_AcademyApp.Entities;
using Class7_AcademyApp.Enums;

namespace Class7_AcademyApp.Helpers
{
    public class ParticipantHelper
    {
        public static void FindParticipantByRole(Participant[] participants, AcademyRole role)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var participant in participants)
            {
                if (participant.Role == role)
                    participant.PrintFullName();
            }
        }
    }
}
