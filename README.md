# 🔊 NetCoreAI Project 11 - OpenAI Text to Speech (TTS)

Bu proje, **.NET Console Application** ile **OpenAI Text-to-Speech (TTS) API** kullanarak girilen metni **MP3 ses dosyası** olarak kaydeder.  
Kullanıcıdan alınan metin OpenAI `tts-1` modeline gönderilir, dönen ses verisi `output.mp3` dosyasına yazılır ve otomatik olarak açılır.  

---

## 🛠️ Kullanılan Teknolojiler
- .NET 8 / 9 Console Application  
- OpenAI Audio API (`/v1/audio/speech`, model: `tts-1`)  
- HttpClient (API çağrısı için)  
- Newtonsoft.Json (JSON serialize/deserialize)  

---

## 📂 Proje Yapısı
- `Program.cs` → Konsoldan metin alır, OpenAI TTS API’ye gönderir ve `output.mp3` dosyasına kaydeder.  
- `.csproj` → Proje yapılandırma dosyası  

---

## ⚙️ Kurulum ve Çalıştırma
1. Repo’yu klonla:
   git clone https://github.com/kullaniciadiniz/NetCoreAI_Project_11_OpenAITTS.git
   cd NetCoreAI_Project_11_OpenAITTS
Program.cs içinde kendi OpenAI API anahtarını ekle:
private static readonly string apiKey = "YOUR_API_KEY";

Konsol uygulamasını çalıştır:
dotnet run
Konsolda örnek kullanım:
Metni Giriniz:
> Yapay zeka ile seslendirme denemesi.

Ses Dosyası Oluşturuluyor....
Ses dosyası 'output.mp3' olarak kaydedildi!
Çıktı: output.mp3 dosyası oluşturulur ve bilgisayarın varsayılan oynatıcısıyla açılır.

✨ Özellikler
✔️ OpenAI TTS API ile metni sese dönüştürme

✔️ Ses verisini MP3 formatında kaydetme

✔️ Otomatik olarak ses dosyasını oynatma

✔️ API’den farklı ses modellerini (voice) seçebilme﻿
