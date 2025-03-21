namespace ddPotLuckClassLibrary
{
    // Version 0.001 bump

    public class dtblRequestData
    {
        public Int64 idEvent { get; set; }
        public string? Draw { get; set; }
        public string? SortColumn { get; set; }
        public string? SortColumnDirection { get; set; }
        public string? SearchValue { get; set; }
        public int PageSize { get; set; }
        public int Skip { get; set; }

    }


    public partial class ddParticipantDTO
    {
        public short level { get; set; }
        public long idEvent { get; set; }
        public long idEventItem { get; set; }
        public string Description { get; set; }
        public float nRequested { get; set; }
        public float nProvided { get; set; }
        public float nRemaining { get; set; }
    }
}