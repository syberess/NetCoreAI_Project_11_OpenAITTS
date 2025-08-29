﻿using System.Text;
using Newtonsoft.Json;

class Program
{
    private static readonly string apiKey = "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";

    static async Task Main(string[] args)
    {
        Console.WriteLine("Metni Giriniz:");
        string input;
        input = Console.ReadLine();

        if(!string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Ses Dosyası OLuşturuluyor....");
            await GenerateSpeech(input);
            Console.WriteLine("Ses dosyası 'output mp3' olarak kaydedildi! ");
            System.Diagnostics.Process.Start("explorer.exe", "output.mp3");
        }
    }

    static async Task GenerateSpeech(string text)
    {
        using(HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            var requestBody = new
            {
                model = "tts-1",
                input = text,
                voice = "alloy" //ses tonu ile ilgili model farklı modellerde mevcut
            };

            string json = JsonConvert.SerializeObject(requestBody);
            HttpContent content = new StringContent(json,Encoding.UTF8,"application/json");

            HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/audio/speech", content);

            if(response.IsSuccessStatusCode)
            {
                byte[] audioBytes = await response.Content.ReadAsByteArrayAsync();
                await File.WriteAllBytesAsync("output.mp3", audioBytes);
            }
            else
            {
                Console.WriteLine("Bir hata oluştu");
            }

        }
    }
}