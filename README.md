# [Store module] Custom-Permission

flag @css/custom-permission is already a VIP already configured originally, the name is technical details but it works without permission 100, which is the original default
Name Bonus module for Store: Awards players bonus credits if their name contains specific promotional texts, with customizable intervals and bonus amounts.
Edit file game\csgo\addons\counterstrikesharp\configs\admin_groups.exemple.json for admin_groups.json
Config `admin_groups.json`:
```
{
  "#css/admin": {
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
      "@css/vip",
      "@css/generic",
      "@css/chat",
      "@css/vote",
      "@css/custom-permission"
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

# Config json
```
"css_vip_adduser \"{SteamID}\" \"VIP_Gold\" \"40000\""
        },
        {
          "Days": 60,
          "Price": 3500,
          "Command": "css_addadmin \"{SteamID}\" \"{NameUser}\" \"@css/custom-permission" \"40 40000\""
        }
      ]
    }
  ],
  "ConfigVersion": 1
}
```

Dependence
`https://github.com/NaathySz/Store-Vip`
