﻿
namespace FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public sealed class Payment
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? ProductId { get; internal set; }
    }
}