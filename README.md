# VModManager

VModManager is a lightweight preset-based mod manager designed for GTA V modding.  
It allows you to organize mod files into presets, switch between them instantly, and import/export full mod setups as shareable packages.

---

## Features

- Create and manage mod presets, quickly switch between them without drag-and-dropping everytime in your GTA V directory
- Import and export presets as `.vmpreset` packages for ease
- Add or remove mod files (.asi, .dll, etc) per preset
- Update system with GitHub releases for easy access to the latest version, without reinstalling the whole application

---

## How It Works

Each preset is simply a folder inside a configured **Library directory**:
```
Library/
├── Vanilla/
├── SSA/
├── VFastForward/
├── Chaos Mod/
├── ...
```
Each folder contains the mod files assigned to that preset.
When a preset is applied, files are copied into your GTA V directory, old ones moved back, vice versa.

---

## Future to-do

- [ ] Profile profiles per GTA installation

---

## Disclaimer

This tool does not modify game memory or inject code.  
It only manages files on disk for modding purposes. 
It's open source.

---