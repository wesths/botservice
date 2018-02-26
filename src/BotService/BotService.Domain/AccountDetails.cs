using System;

namespace BotService.Domain
{
    public class AccountDetails
    {
        public int PersonNo { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public decimal NowDue { get; set; }
        public decimal BalanceOutstanding { get; set; }
        public DateTime LastPaymentDate { get; set; }
    }
}
