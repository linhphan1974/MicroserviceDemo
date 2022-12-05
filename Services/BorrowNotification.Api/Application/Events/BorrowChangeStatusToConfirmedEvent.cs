﻿using RabbitMQEventBus;

namespace BookOnline.BorrowNotification.Api.Application.Events
{
    public record BorrowChangeStatusToConfirmedEvent : ApplicationEvent
    {
        public int BorrowId { get; set; }
        public string MemberName { get; set; }
        public string Status { get; set; }

        public BorrowChangeStatusToConfirmedEvent(int borrowId, string memberName, string status)
        {
            BorrowId = borrowId;
            MemberName = memberName;
            Status = status;
        }
    }
}
