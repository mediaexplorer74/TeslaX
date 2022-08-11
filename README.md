# TeslaX 

TeslaX is my fork of [PowerwallCompanionX](https://github.com/tomhollander/PowerwallCompanionX) project.

## About Powerwall Companion X

Original "Powerwall Companion X" is a Xamarin Forms - based Android app for monitoring your Tesla Powerwall 2 battery. 

It has similar functionality to the official Tesla app, but it's designed to be 
more of an "always on" dashboard, running on a spare device. 


Very cool app, IMHO :)

## My 2 cents

- Windows UWP version added;
- iOS version added (but not tuned by me because of "no iphone"))
- TeslaAPI downgraded to .NET 1.4
- PanCardView downgraded to .NET 1.4
- SyncFuzion lib cutted (this community not works at RU / geo-blocked, so I don't want to use it)
- Few code comments added and app architecture revised for my future plans to port TeslaX at my "winphone" Lumia 950 :)

## Tech Notes

Current supported min. Windows OS build: 16299 

14393 planned in near future, So, TeslaAPI and PanCardView libs temporary disabled! 

Goal: additional app debugging and bug-fixing after solution "downshifting" 
(decreasing min. os. builds, in 2 words).

## DIY

I'm sharing the source in case anyone wants to improve it or is curious about the underlying APIs.

## Referencies

- https://github.com/tomhollander Tom Hollander, great C# .NET Developer
- https://github.com/tomhollander/PowerwallCompanionX PowerwallCompanionX, original, for "Droidphones"
- https://github.com/tomhollander/TeslaAuth TeslaAuth .NET Standard 2 library for Tesla API auth

## .
AS IS. No support. RnD only.

## ..
-- [m][e] 2022