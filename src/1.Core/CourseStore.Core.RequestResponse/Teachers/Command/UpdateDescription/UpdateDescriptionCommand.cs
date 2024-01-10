﻿using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Command.UpdateDescription
{
    public class UpdateDescriptionCommand : ICommand
    {
        public int TeacherId { get; set; }
        public string Description { get; set; }

    }
}
