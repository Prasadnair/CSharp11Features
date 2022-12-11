// See https://aka.ms/new-console-template for more information
using CSharp11Features.NewLineInInterpolation;
using CSharp11Features.PatternMatching;
using CSharp11Features.RawLiteralString;
using CSharp11Features.RequiredKeyword;

//Raw String Literals.
var _rawOldApproach= DisplayRawStrings.OldApproach();
var _rawNewApproach= DisplayRawStrings.NewApproach();
var _rawInterpolation = DisplayRawStrings.InterpolationApproach();

Console.WriteLine(_rawOldApproach);
Console.WriteLine(_rawNewApproach);
Console.WriteLine(_rawInterpolation);

//Patter Matching with List
var _match = ListPatternExample.IsMatch();
Console.WriteLine(_match);
var _notMatch = ListPatternExample.IsNotMatch();
Console.WriteLine(_notMatch);
var _matchWithExpression = ListPatternExample.IsMatchWithExpression();
Console.WriteLine(_matchWithExpression);
//New Line in Interpolation

var _interpolation = NewLineInInterpolationExample.NewLineApproach();
Console.WriteLine(_interpolation);

//Required Keyword
var _required = new RequiredExample
{
    FirstName = "Prasad",
    LastName = "Raveendran"
};
