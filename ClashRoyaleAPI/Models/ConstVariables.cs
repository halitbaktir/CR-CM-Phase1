using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClashRoyaleAPI.Models
{
    public class ConstVariables
    {
        public const string AuthToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6ImJhNDE5OGZmLTY0ZDAtNDU3My05NjIxLThlMzQzNDBjYTc1YSIsImlhdCI6MTU4NzU4NzQ1Nywic3ViIjoiZGV2ZWxvcGVyL2IyM2JkNDQ5LWEyOWItMTM1Yy0xOGU1LTFmNzcxYzg0NGQwNyIsInNjb3BlcyI6WyJyb3lhbGUiXSwibGltaXRzIjpbeyJ0aWVyIjoiZGV2ZWxvcGVyL3NpbHZlciIsInR5cGUiOiJ0aHJvdHRsaW5nIn0seyJjaWRycyI6WyIyNC4xMzMuMTQxLjE5Il0sInR5cGUiOiJjbGllbnQifV19.1uU1EVMGvWDnvq4F89TsyCUCS7sn7wHOaonW9zMPQEo4ZqGr4dLmoNUrtwoxR_jxvR_5t9iotLNkoQq2iYzNqQ";

        public const string BaseURL = "https://api.clashroyale.com/v1/";

        public const string ClansURL = "clans";

        public const string PlayersURL = "players";

        public const string CardsURL = "cards";

        public const string TournamentsURL = "tournaments";

        public const string LocationsURL = "locations";

        public const string GlobalTournamentsURL = "globaltournaments";
        
        public const string Quot = "\"";

        public const string ReplaceImage = Quot + "medium" + Quot + ":";
    }
}