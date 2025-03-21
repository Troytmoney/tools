import os
import shutil

# Define the file paths
original_file = r"C:\Users\Troy\AppData\Roaming\Microsoft\Windows\Themes\TranscodedWallpaper"
temp_folder = os.getenv('TEMP')  # Get the temp folder path
file_name = os.path.basename(original_file)  # Extract the file name

# Change extension to .png
new_file_name = os.path.splitext(file_name)[0] + ".png"
new_file_path = os.path.join(temp_folder, new_file_name)

# Copy the file
shutil.copy2(original_file, new_file_path)

print(f"File copied to: {new_file_path}")
