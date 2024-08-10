# [Store module] Custom-Permission

flag @css/custom-permission is already a VIP already configured originally, the name is technical details but it works without permission 100, which is the original default
Name Bonus module for Store: Awards players bonus credits if their name contains specific promotional texts, with customizable intervals and bonus amounts.
Config `admin_groups.json`:
```
{
  "css/admin": {
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

```
{
  "vip_store_given_by": {//Defalt "example_command"
    "flags": [
      "@css/custom-permission"
    ],
    "check_type": "all",
    "enabled": true
  }
}
```

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
