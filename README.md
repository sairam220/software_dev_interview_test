# software_dev_interview_test

# Rhino Sample Plugin

This is a simple Rhino plugin that demonstrates how to create a rectangular surface using WPF UI elements and RhinoCommon in C#.

## Installation

1. Download and install Rhino 7 from [here](https://www.rhino3d.com/download/).
2. Download and install Visual Studio 2022 (any edition) from [here](https://visualstudio.microsoft.com/vs/).
3. Clone this repository or download the source code.

## Usage

1. Build the project in Visual Studio to generate the `RhinoSamplePlugin.dll`.
2. Open Rhino 7.
3. Run the `LoadPlugin` command in Rhino and select the `RhinoSamplePlugin.dll` you built.
4. Run the `SamplePluginCommand` command in Rhino to open the WPF window.
5. Enter the desired parameters for the rectangular surface (length, width, center coordinates).
6. Click the "Generate" button to create the surface in Rhino.

## Project Structure

- `SamplePluginCommand.cs`: Contains the main command logic for opening the WPF window.
- `SampleWpfWindow.xaml` and `SampleWpfWindow.xaml.cs`: Define the layout and behavior of the WPF window.
- `SamplePlugin.csproj`: Project configuration for the plugin.
- `.vscode/launch.json` and `.vscode/tasks.json`: Configuration files for Visual Studio Code tasks and debugging.

## Notes

- This plugin is intended as a simple example and might not cover all edge cases.
- Be sure to refer to the official RhinoCommon documentation for more advanced plugin development.

## License

This project is licensed under the [MIT License](LICENSE).
