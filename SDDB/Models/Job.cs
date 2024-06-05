using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SDDB.Models
{
    [Table("Jobs")]
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("id")]
        public string JobId { get; set; }

        [JsonPropertyName("project")]
        public string Project { get; set; }

        [JsonPropertyName("spider")]
        public string Spider { get; set; }

        [JsonPropertyName("start_time")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("end_time")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("log_url")]
        public string LogUrl { get; set; }

        [JsonPropertyName("items_url")]
        public string ItemsUrl { get; set; }
    }

    public class DateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var val = reader.GetString();
            if (val == null)
            {
                return DateTime.MinValue;
            }
            return DateTime.Parse(val);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd HH:mm:ss.ffffff"));
        }
    }
}
