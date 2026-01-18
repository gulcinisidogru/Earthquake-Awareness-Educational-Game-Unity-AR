# 🌍 Earthquake-Awareness-Educational-Game-Unity-AR

[![Unity](https://img.shields.io/badge/Unity-2022.3+-black.svg?style=for-the-badge&logo=unity)](https://unity.com/)
[![ARFoundation](https://img.shields.io/badge/AR-Foundation-blue.svg?style=for-the-badge)](https://unity.com/unity/features/arfoundation)

This repository contains the Augmented Reality (AR) components of the **Earthquake-Awareness-Educational-Game-Kotlin** project. It includes 3D models, scenes, and interaction code (C#) designed to integrate with the mobile application (Kotlin) side of the project.

---

## 🎮 How it Works
In AR mode, which starts after the main game, the process works as follows:
1. The student first scans the ground.
2. Upon seeing the alert that the ground has been detected, they place objects such as tables and cabinets in the room in order.
3. When the placed objects are clicked, they receive informative messages and warnings about earthquake safety.

> **IMPORTANT:** Don't forget to grant **camera permission** on your phone when running the application!

---

## 🛠 Technical Requirements
To run this project on your local computer, the following installations must be completed:
* **Unity Version:** 2022.3 LTS or higher.
* **Platform:** Android (an ARCore-supported device is required).
* **Packages:** AR Foundation, ARCore XR Plugin.

---

## ⚙️ Installation and Operation Guide

### 1. Downloading the Repository
First, download this repository to your computer or copy it to your local folder using the `git clone` command.

### 2. Importing into a Unity Project
* **If Downloaded as a File:** Drag and drop the files from the `Assets` folder into the `Assets` folder in your Unity project.
* **If Downloaded as a Package:** Import the package in Unity by following the path `Assets -> Import Package -> Custom Package...`.

### 3. Scene Settings
* Open the AR scene under the `Assets/Scenes` folder.
* If the models appear pink (URP/HDRP conflict), adjust the materials to match your project by following the path `Edit -> Rendering -> Materials -> Convert Selected Materials`.

## ⚠️ Challenges You Might Encounter
I know, sometimes even the simplest project can take days to get up and running in Unity. I also had to try many times during this process (why do you think I bought 70+ APKs? 😅).

Below are the links to the solutions I used for the **black screen** problem, one of the most common issues:
* [Unity Discussions - Black Screen Issue](https://discussions.unity.com/t/after-building-the-app-i-am-greeted-by-a-black-screen/1608678)
* [StackOverflow - Unity Android Black Screen](https://stackoverflow.com/questions/76410780/unity-android-app-black-screen-on-startup)

Good luck, I believe in you!

---

## 📦 Assets and Resources Used
Cabinet and desk models have been added to the repository. Due to size limitations, I had to share the cabinet as a zip/rar file. If you encounter errors while importing to your local machine, adding the assets to your project from scratch using the links below may provide a cleaner process:

* **Old Wooden Cabinet:** [Asset Store Link](https://assetstore.unity.com/packages/3d/props/furniture/old-wooden-cabinet-106249)

* **Dark Wave Paint - Table 01:** [Asset Store Link](https://assetstore.unity.com/packages/3d/props/dark-wave-paint-table-01-306300)

<p align="left">
<img width="125" height="200" src="https://github.com/user-attachments/assets/4483e435-2fdf-4d8b-ba38-29f5c75d0449" />
<img width="326" height="135" src="https://github.com/user-attachments/assets/cf7c7597-f452-408b-8b24-29f944e9f643" />
</p>

---

## 🤝 Contribute
1. Fork the Project: Copy it to your account using the button in the upper right corner.
2. Make Your Changes: Develop the copy (fork) in your account.
3. Create a Pull Request (PR): You can submit a Pull Request if you have fixed a bug in the original project or made a technical improvement that benefits everyone.

> **Note:** To maintain project structure, permission to create branches directly on this repository is not granted.


---

## 👩‍💻 Developer
**Gülçin İşidoğru** *The developer who challenges the Android world by acquiring 70+ APKs.* 😉

[<img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white" />](https://www.linkedin.com/in/gulcinisidogru/)

---
> **Main Application Repository (Kotlin):** [Earthquake-Awareness-Educational-Game-Kotlin](https://github.com/gulcinisidogru/Earthquake-Awareness-Educational-Game-Kotlin)
