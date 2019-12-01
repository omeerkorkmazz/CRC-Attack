# CRC-Attack
WEP (*Wired Equivalent Privacy Owner*) is the privacy protocol specified in IEEE 802.11 to provide wireless LAN users protection against casual eavesdropping. It uses encrypted CRC as the integrity protection mechanism. However, this mechanism might be flawed in WLAN Security since CRC-32 is an excellent checksum for detecting errors, but an awful choice for a cryptographic hash. The CRC-32 is a linear function of the message, showing that an attacker can simply modify an encrypted message and easily fix the ICV. Being able to modify encrypted packets provides for a nearly limitless number of very simple attacks. This *CRC-Attack* implementation has shown the flaws in WEP instead of the integrity and replay protection, and has been developed for a Network Security course project in Sabanci University.

## Built With

* [NET Framework](https://dotnet.microsoft.com/) - NET framework has been used to develop the system.
* [CRC32 .NET 1.2.0](https://www.nuget.org/packages/Crc32.NET/) - Crc32C.NET library has been used to make CRC calculations.

## Authors

* **[Omer KORKMAZ](https://www.linkedin.com/in/omerkorkmazz/)** - *Owner*


## License

This project is licensed under the MIT License.


