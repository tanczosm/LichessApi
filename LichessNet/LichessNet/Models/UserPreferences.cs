using LichessNet.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessNet.Models
{
    public partial class UserPreferences
    {
        [Newtonsoft.Json.JsonProperty("dark", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Dark { get; set; }

        [Newtonsoft.Json.JsonProperty("transp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Transp { get; set; }

        [Newtonsoft.Json.JsonProperty("bgImg", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Uri BgImg { get; set; }

        [Newtonsoft.Json.JsonProperty("is3d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Is3d { get; set; }

        [Newtonsoft.Json.JsonProperty("theme", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UserPreferencesTheme Theme { get; set; }

        [Newtonsoft.Json.JsonProperty("pieceSet", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UserPreferencesPieceSet PieceSet { get; set; }

        [Newtonsoft.Json.JsonProperty("theme3d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UserPreferencesTheme3d Theme3d { get; set; }

        [Newtonsoft.Json.JsonProperty("pieceSet3d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UserPreferencesPieceSet3d PieceSet3d { get; set; }

        [Newtonsoft.Json.JsonProperty("soundSet", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UserPreferencesSoundSet SoundSet { get; set; }

        [Newtonsoft.Json.JsonProperty("blindfold", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Blindfold { get; set; }

        [Newtonsoft.Json.JsonProperty("autoQueen", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object AutoQueen { get; set; }

        [Newtonsoft.Json.JsonProperty("autoThreefold", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object AutoThreefold { get; set; }

        [Newtonsoft.Json.JsonProperty("takeback", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Takeback { get; set; }

        [Newtonsoft.Json.JsonProperty("moretime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Moretime { get; set; }

        [Newtonsoft.Json.JsonProperty("clockTenths", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object ClockTenths { get; set; }

        [Newtonsoft.Json.JsonProperty("clockBar", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ClockBar { get; set; }

        [Newtonsoft.Json.JsonProperty("clockSound", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ClockSound { get; set; }

        [Newtonsoft.Json.JsonProperty("premove", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Premove { get; set; }

        [Newtonsoft.Json.JsonProperty("animation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Animation { get; set; }

        [Newtonsoft.Json.JsonProperty("captured", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Captured { get; set; }

        [Newtonsoft.Json.JsonProperty("follow", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Follow { get; set; }

        [Newtonsoft.Json.JsonProperty("highlight", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Highlight { get; set; }

        [Newtonsoft.Json.JsonProperty("destination", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Destination { get; set; }

        [Newtonsoft.Json.JsonProperty("coords", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Coords { get; set; }

        [Newtonsoft.Json.JsonProperty("replay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Replay { get; set; }

        [Newtonsoft.Json.JsonProperty("challenge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Challenge { get; set; }

        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Message { get; set; }

        [Newtonsoft.Json.JsonProperty("coordColor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object CoordColor { get; set; }

        [Newtonsoft.Json.JsonProperty("submitMove", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object SubmitMove { get; set; }

        [Newtonsoft.Json.JsonProperty("confirmResign", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object ConfirmResign { get; set; }

        [Newtonsoft.Json.JsonProperty("insightShare", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object InsightShare { get; set; }

        [Newtonsoft.Json.JsonProperty("keyboardMove", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object KeyboardMove { get; set; }

        [Newtonsoft.Json.JsonProperty("zen", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Zen { get; set; }

        [Newtonsoft.Json.JsonProperty("moveEvent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object MoveEvent { get; set; }

        [Newtonsoft.Json.JsonProperty("rookCastle", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object RookCastle { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }
}
