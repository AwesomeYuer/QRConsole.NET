﻿using Microshaoft;
using System;

Console.WriteLine("======");
Console.WriteLine("======");
Console.WriteLine("======\b");

Console.Out.WriteQRCodeLine
                (
                    "https://www.cnblogs.com/stulzq/p/14282461.html?Thanks"
                    , placeholderChar:      '♂' //㊚㊛囍♀♂♂♀☿♁⚢⚣⚤⚥⚦⚧⚨
                    , outputPostionLeft:    100
                    , outputPostionTop:     10
                );

Console.WriteLine("㊚㊛囍♀♂♂♀☿♁⚢⚣⚤⚥⚦⚧⚨");
Console.WriteLine();

var s =
"""
♂㊚囍㊛♀
满屏荒唐言
一把辛酸泪
都言作者痴
谁解比特位
~ Duang ~
""";
Console.Out.WriteQRCodeLine
            (
                s
                //, qrCompact: true
                //, pureBarcode: true
            );
