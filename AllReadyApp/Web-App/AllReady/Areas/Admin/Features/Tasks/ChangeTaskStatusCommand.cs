﻿using AllReady.Models;
using MediatR;

namespace AllReady.Areas.Admin.Features.Tasks
{
    public class ChangeTaskStatusCommand : IAsyncRequest<TaskChangeResult>
    {
        public int TaskId { get; set; }
        public string UserId { get; set; }
        public TaskStatus TaskStatus { get; set; }
        public string TaskStatusDescription { get; set; }
    }
}
