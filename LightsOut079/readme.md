# LightsOut079 Plugin

A plugin for SCP: Secret Laboratory using the EXILED framework. This plugin adds functionality to temporarily disable SCP-079 when a player shoots a camera while SCP-079 is observing the room.

## Features

- Temporarily disables SCP-079 when a player shoots a camera in the same room SCP-079 is watching.
- Customizable probability of disabling SCP-079.
- Cooldown system to prevent repeated disables.
- Displays hints to the shooter and SCP-079, explaining the current state.

## Installation

1. Download the compiled `.dll` file from the [Releases](https://github.com/Rech1n/LightsOut079/releases) section.
2. Place the `.dll` file in your server's `Plugins` folder.
3. Restart your server.

## Configuration

After the first run, a configuration file named `LightsOut079.yml` will be created in the `Configs` folder. You can customize the settings using the following options:

```yaml
# Enables or disables the plugin.
is_enabled: true

# The probability of disabling SCP-079 when a camera is shot (0.0 = 0%, 1.0 = 100%).
disable_chance: 0.5

# The duration (in seconds) for which SCP-079 is disabled.
disable_duration: 5

# The cooldown (in seconds) before SCP-079 can be disabled again.
cooldown: 10
