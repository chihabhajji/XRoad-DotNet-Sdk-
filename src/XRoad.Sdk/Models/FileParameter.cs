﻿using System.CodeDom.Compiler;
using System.IO;

namespace XRoad.Sdk;

[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class FileParameter
{
    public FileParameter(Stream data) : this (data, null, null)
    {
    }

    public FileParameter(Stream data, string fileName) : this (data, fileName, null)
    {
    }

    public FileParameter(Stream data, string fileName, string contentType)
    {
        Data = data;
        FileName = fileName;
        ContentType = contentType;
    }

    public Stream Data { get; private set; }

    public string FileName { get; private set; }

    public string ContentType { get; private set; }
}