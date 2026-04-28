# Time Pages (Unity WebGL Game)

This repository contains a **Unity WebGL build** of a game (served as a static website).

## Play / run
### Option 1: Open the GitHub Pages site
If GitHub Pages is enabled for this repo, you can play it directly in your browser.

### Option 2: Run locally (recommended for testing)
Because this is a WebGL build, it should be served from a local web server (opening `index.html` directly may fail due to browser restrictions).

#### Using Python
```bash
python -m http.server 8000
```
Then open: http://localhost:8000

#### Using Node (any static server)
```bash
npx serve
```

## Controls (from the page)
- Press **1**, **2**, or **3** to pick a character.
- Use the **arrow keys** to move.
- Press **Space** when you finish moving the character.
- Press **1**, **2**, or **3** to pick another character.
- Stand on the **red** button to open doors.
- Stand on the **green** button to advance to the next level.

## Repository structure
- **`index.html`** — Main page that loads the Unity WebGL build and displays instructions.
- **`Build/`** — Unity WebGL build outputs:
  - `Time.loader.js`
  - `Time.framework.js`
  - `Time.data`
  - `Time.wasm`
- **`TemplateData/`** — Unity WebGL template assets (CSS/images for the loader UI).
- **`images/`** — Site images (currently includes `favicon.png`).

## Overview
This repo is essentially a static site wrapper around a Unity WebGL export. The HTML page creates a canvas, loads the Unity loader script, and points it at the `Build/` artifacts.
