# AR Coffee Shop

An Augmented Reality mobile application developed with Unity 6, AR Foundation, and Google ARCore. The application detects physical planar surfaces in real-world environments and allows users to place, inspect, and interact with a modular 3D coffee shop scene rendered using the Universal Render Pipeline (URP).

---

## Overview

AR Coffee Shop bridges spatial computing and interactive visualization by enabling real-time horizontal plane tracking and touch-based spatial placement on ARCore-supported Android devices. The project is designed with mobile performance and visual fidelity in mind, utilizing Unity's Universal Render Pipeline, ShaderGraph materials, and an optimized IL2CPP ARM64 build pipeline.

A pre-built Android release package (`ARShop.apk`) is included directly within the repository for immediate deployment and testing.

---

## Technical Specifications

| Specification | Details |
| :--- | :--- |
| **Engine Version** | Unity 6000.5.5f1 (Unity 6) |
| **Scripting Backend** | IL2CPP (AOT Compilation) |
| **Target Architecture** | ARM64 |
| **Minimum Android SDK** | API Level 28 (Android 9.0 Pie) |
| **Target Android SDK** | Automatic (Latest Installed Platform SDK) |
| **Render Pipeline** | Universal Render Pipeline (URP 17.5.0) |
| **XR Subsystems** | AR Foundation 6.5.1, Google ARCore XR Plugin 6.5.1 |
| **Input Handling** | Unity Input System 1.19.0 / Mobile Touch Subsystem |
| **Build Automation** | Gradle 9.1.0 with Custom JVM Heap Allocation (-Xmx4096M) |

---

## Key Features

* **Real-Time Surface Tracking:** Integrates AR Foundation's plane detection to continuously detect and track physical horizontal surfaces (floors, tabletops).
* **Touch-Based AR Raycasting:** Raycasts screen-space touch coordinates against detected trackables (`TrackableType.PlaneWithinPolygon`) for placement precision.
* **Dynamic Instantiation and Relocation:** Automatically spawns the coffee shop environment on initial surface hit and dynamically updates position and orientation on subsequent taps.
* **Custom ShaderGraph Integration:** Utilizes custom URP ShaderGraph shaders for stylized low-poly rendering across diverse mobile GPU chipsets.
* **Optimized Android Build Pipeline:** Configured with custom Gradle parameters (`gradleTemplate.properties`) ensuring robust builds with AndroidX, Jetifier, and extended socket timeouts.

---

## Repository Structure

```
ARCoffeeShop/
├── Assets/
│   ├── ARPlacementManager.cs          # Core AR raycast and object placement controller
│   ├── ARShop.unity                   # Primary production AR scene
│   ├── firsttry.unity                 # Initial XR subsystem verification scene
│   ├── Prefabs/
│   │   └── CoffeeShop.prefab          # Master assembly prefab of the coffee shop environment
│   ├── Plugins/
│   │   └── Android/
│   │       └── gradleTemplate.properties # Custom Gradle daemon and build properties
│   ├── Settings/
│   │   └── Build Profiles/            # Unity 6 Build Profile configurations for Android
│   ├── Stylized Low Poly Coffee Shop Props Pack – Free/
│   │   ├── Materials/                 # URP materials and ShaderGraph shaders
│   │   ├── Models/                    # FBX geometry (floors, walls, counters, props)
│   │   ├── Prefabs/                   # Individual modular coffee shop prop prefabs
│   │   └── Textures/                  # Texture atlases and palette maps
│   └── XR/
│       ├── Loaders/                   # ARCore and Simulation subsystem loaders
│       └── Settings/                  # ARCore runtime settings and build target configurations
├── Packages/
│   ├── manifest.json                  # Package dependencies and version definitions
│   └── packages-lock.json             # Resolved package dependency tree
├── ProjectSettings/                   # Engine, graphics, input, and player settings
├── ARShop.apk                         # Compiled release APK for Android
├── .gitattributes                     # Git line-ending normalization rules
├── .gitignore                         # Comprehensive Unity source control exclusions
├── LICENSE                            # GNU General Public License v3.0
└── README.md                          # Project documentation and architectural specification
```

---

## Getting Started

### Prerequisites

* **Unity Hub** installed.
* **Unity Editor 6000.5.5f1** installed with the **Android Build Support** module (including Android SDK & NDK Tools and OpenJDK).
* An **ARCore-compatible Android device** running Android 9.0 (API Level 28) or higher with **Google Play Services for AR** installed.

### Setup and Compilation

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/a4kashhh/ARCoffeeShop.git
   cd ARCoffeeShop
   ```

2. **Open in Unity:**
   * Launch Unity Hub.
   * Click **Add** -> **Add project from disk**.
   * Select the cloned `ARCoffeeShop` folder.
   * Open the project with Unity Editor `6000.5.5f1`.

3. **Verify Build Settings:**
   * In the Editor menu, navigate to **File > Build Profiles** (or **Build Settings**).
   * Confirm the platform is switched to **Android**.
   * Ensure `Assets/ARShop.unity` is included in the scene list.

4. **Build and Deploy:**
   * Connect your Android device via USB with USB Debugging enabled.
   * Click **Build and Run** to compile and launch the application directly onto your hardware.

---

## Direct APK Installation

To install the application directly without compiling from source:

1. Locate `ARShop.apk` in the root of this repository.
2. Transfer `ARShop.apk` to your target Android device via USB, ADB, or file transfer.
3. On the device, open the file using a file manager and authorize installation from your file browser.
4. Launch the application and grant the requested camera permission when prompted.

---

## Application Usage

1. Open **ARShop** on your Android device.
2. Slowly pan the device camera across a well-lit floor, rug, or table surface to allow ARCore to detect feature points and construct horizontal plane polygons.
3. Tap anywhere on the detected surface on your screen to place the coffee shop model.
4. Tap another location on the scanned surface to move the coffee shop to the new position.

---

## Copyright and Licensing

### Project Copyright
Copyright (c) 2026 Akash Kumar Pandey. All rights reserved.

### Open Source License
The software source code in this repository is licensed under the **GNU General Public License v3.0**. Review the [LICENSE](LICENSE) file for comprehensive rights and obligations.

### Third-Party Attributions
* **3D Assets:** 3D props and environment models originate from the *Stylized Low Poly Coffee Shop Props Pack – Free* and are governed under the Unity Asset Store End User License Agreement (EULA).
* **Unity Technologies:** Unity, AR Foundation, and the Universal Render Pipeline are trademarks or registered trademarks of Unity Technologies.
* **Google LLC:** Google ARCore and Google Play Services for AR are trademarks or registered trademarks of Google LLC.
