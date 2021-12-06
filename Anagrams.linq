<Query Kind="Statements" />



string str1 = "dormitory";
string str2 = "dirty room";

string aa = String.Concat(str1.OrderBy(c => c)).ToUpper();
string bb = String.Concat(str2.OrderBy(c => c)).ToUpper();

aa = aa.Replace(" ", "");
bb = bb.Replace(" ", "");

var result = aa==bb;
result.ToString();

result.Dump();