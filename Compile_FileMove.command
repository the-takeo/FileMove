#!/bin/bash
MY_DIRNAME=$(dirname $0)
cd $MY_DIRNAME
mcs -r:System.Xml.Linq.dll FileMove.cs