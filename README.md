# Sungero.Plugins.Sdk

[![Publish](https://github.com/DirectumCompany/Sungero.Plugins.Sdk/actions/workflows/release.yml/badge.svg)](https://github.com/DirectumCompany/Sungero.Plugins.Sdk/actions/workflows/release.yml)
[![NuGet](https://img.shields.io/nuget/v/sungero.plugins.sdk.svg)](https://www.nuget.org/packages/Sungero.Plugins.Sdk/)

SDK плагинов к системе DirectumRX.

#### Модуль **Cryptography**:
* **HashAlgorithmWrapper** Предоставляет удобные методы для доступа к алгоритму хэширования.
* **ICryptographyPlugin** Содержит контракт для создания плагина криптографии.
* **ISigner** Содержит контракт для создания класса подписания.
* **ICloudSignPlugin** Содержит контракт для создания облачного плагина криптографии.
* **ICryptographyPluginDataProvider** Содержит контракт поставщика данных для облачного плагина криптографии.

См. также [шаблон проекта плагина подписания](https://github.com/DirectumCompany/Sungero.Plugins.Templates).
