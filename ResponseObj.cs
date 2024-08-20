using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class issuer
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("phone")]
    public string phone { get; set; }

    [JsonProperty("website")]
    public string website { get; set; }

}

public class location
{
    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("latitude")]
    public string latitude { get; set; }

    [JsonProperty("longitude")]
    public string longitude { get; set; }

    [JsonProperty("alpha2")]
    public string alpha2 { get; set; }

    [JsonProperty("alpha3")]
    public string alpha3 { get; set; }

}

public class data
{
    [JsonProperty("bin")]
    public string bin { get; set; }

    [JsonProperty("brand")]
    public string brand { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("category")]
    public string category { get; set; }

    [JsonProperty("issuer")]
    public issuer issuer { get; set; }

    [JsonProperty("location")]
    public location location { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
