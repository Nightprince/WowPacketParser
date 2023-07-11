using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V10_0_0_46181.UpdateFields.V10_1_5_50232
{
    public class QuestLog : IQuestLog
    {
        public System.Nullable<long> EndTime { get; set; }
        public System.Nullable<int> QuestID { get; set; }
        public System.Nullable<uint> StateFlags { get; set; }
        public System.Nullable<uint> ObjectiveFlags { get; set; }
        public System.Nullable<short>[] ObjectiveProgress { get; } = new System.Nullable<short>[24];
    }
}

