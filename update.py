import os
import requests
import winreg
import subprocess
import json

# Function to get the installed version from the registry
def get_installed_version():
    try:
        reg_path = r"SOFTWARE\TroyTech\Tools"
        reg_key = "version"
        
        with winreg.OpenKey(winreg.HKEY_LOCAL_MACHINE, reg_path) as key:
            value, _ = winreg.QueryValueEx(key, reg_key)
            return value
    except Exception as e:
        print(f"Error reading registry: {e}")
        return None

# Function to check the latest version from the server
def check_for_update(current_version):
    server_url = "https://update.troysmithson.com/check_version.php"  # Change to your server URL
    response = requests.get(server_url)
    
    if response.status_code == 200:
        latest_version = response.text.strip()
        if latest_version > current_version:
            return latest_version
    return None

# Function to download and install the update
def download_and_install_update(latest_version):
    download_url = f"https://update.troysmithson.com/updates/{latest_version}.exe"  # Change to your server URL
    response = requests.get(download_url)
    
    if response.status_code == 200:
        with open(f"{latest_version}.exe", 'wb') as f:
            f.write(response.content)
        
        # Run the installer with the specified arguments
        subprocess.run([f"{latest_version}.exe", "/exenoui", "/qn", "/norestart"], check=True)

# Main function
def main():
    current_version = get_installed_version()
    if current_version:
        print(f"Installed version: {current_version}")
        latest_version = check_for_update(current_version)
        
        if latest_version:
            print(f"New version available: {latest_version}")
            download_and_install_update(latest_version)
        else:
            print("No updates available.")
    else:
        print("Could not get installed version.")

if __name__ == "__main__":
    main()
