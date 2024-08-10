# [Store module] Custom-Permission

flag @css/custom-permission is already a VIP already configured originally, the name is technical details but it works without permission 100, which is the original default
Name Bonus module for Store: Awards players bonus credits if their name contains specific promotional texts, with customizable intervals and bonus amounts.
Config `admin_groups.json`:
```
{
  "#css/dono": {
    "flags": [
      "@css/reservation",
      "@css/generic",
      "@css/kick",
      "@css/ban",
      "@css/unban",
      "@css/vip",
      "@css/slay",
      "@css/changemap",
      "@css/cvar",
      "@css/config",
      "@css/chat",
      "@css/vote",
      "@css/password",
      "@css/rcon",
      "@css/cheats",
      "@css/root"
    ],
    "immunity": 99
  },
  
  "#css/subdono": {
    "flags": [
      "@css/reservation",
      "@css/generic",
      "@css/kick",
      "@css/ban",
      "@css/unban",
      "@css/vip",
      "@css/slay",
      "@css/changemap",
      "@css/chat",
      "@css/vote",
      "@css/password"
    ],
    "immunity": 90
  },
  
  "#css/admin": {
    "flags": [
      "@css/reservation",
      "@css/generic",
      "@css/kick",
      "@css/ban",
      "@css/vip",
      "@css/slay",
      "@css/changemap",
      "@css/chat",
      "@css/vote",
      "@css/password"
    ],
    "immunity": 85
  },
  
  "#css/mod": {
    "flags": [
      "@css/reservation",
      "@css/generic",
      "@css/kick",
      "@css/ban",
      "@css/vip",
      "@css/slay",
      "@css/chat",
      "@css/vote"
    ],
    "immunity": 80
  },
  
  "#css/custom-permission": {
    "flags": [
      "@css/reservation",
      "@css/vip"
    ],
    "immunity": 40
  }
}
```

Edit file game\csgo\addons\counterstrikesharp\configs\admin_overrides.example.json for admin_overrides.json

flag @css/custom-permission is already a VIP already configured originally, the name is technical details but it works without permission 100, which is the original default

# Config
Config will be auto generated. Default:
```json
{
  "ad_texts": [
    "YourAd1",
    "YourAd2"
  ],
  "bonus_credits": 100,
  "interval_in_seconds": 300,
  "show_ad_message": true,
  "ad_message_delay_seconds": 120,
  "ad_message": "Add '{blue}YourAd{white}' to your nickname and earn bonus credits!",
  "ConfigVersion": 1
}
```
[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/L4L611665R)
