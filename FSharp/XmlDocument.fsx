open System.IO

let doc = System.Xml.XmlDocument ()
doc.Load @"c:\PathToYour\file.xml"
let nodes = doc.SelectNodes "/xpath/to/your/nodes"

seq { for n in nodes do n }
