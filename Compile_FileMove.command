#!/bin/bash
MY_DIRNAME=$(dirname $0)
cd $MY_DIRNAME
dmcs -r:System.Xml.Linq.dll FileMove.cs