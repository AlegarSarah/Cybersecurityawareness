using System;
using System.Collections.Generic;

namespace CyberSecurityAwareness
{
    internal class ChatBotResponder //fixed the casing
    {

        //Dictionary with case-insensitive keys
        private static readonly Dictionary<string, string> Responses = new(StringComparer.OrdinalIgnoreCase)
        {
            { "hello",            "Hello! How can I help you stay safe online today?" },
            { "hi",               "Hi there! How can I assist you with cybersecurity today?" },
            { "how are you",      "I'm running securely and ready to help you stay safe online!" },
            { "purpose",          "I can help with: passwords, phishing, safe browsing, malware, scams, VPNs and 2FA!" },
            { "what can you do",  "I can help with: passwords, phishing, safe browsing, malware, scams, VPNs and 2FA!" },
            { "password",         "Use strong passwords: mix uppercase, lowercase, numbers and symbols. Never reuse passwords across sites!" },
            { "phishing",         "Phishing emails mimic trusted sources. Always verify the sender and never click suspicious links!" },
            { "browsing",         "Always use HTTPS sites, avoid public Wi-Fi for sensitive tasks, and keep your browser updated." },
            { "safe",             "Stay safe online by using strong passwords, enabling 2FA, and avoiding suspicious links!" },
            { "internet",         "Always use HTTPS sites, avoid public Wi-Fi for sensitive tasks, and keep your browser updated." },
            { "malware",          "Install reputable antivirus software, avoid downloading from unknown sources, and keep your OS updated." },
            { "virus",            "Install reputable antivirus software, avoid downloading from unknown sources, and keep your OS updated." },
            { "scam",             "Be cautious of unsolicited calls or emails asking for personal info. Legitimate companies never ask for passwords!" },
            { "fraud",            "Be cautious of unsolicited calls or emails asking for personal info. Legitimate companies never ask for passwords!" },
            { "social engineering", "Social engineering tricks people into giving confidential info. Always verify who you are speaking to!" },
            { "two factor",       "Always enable Two-Factor Authentication (2FA) on your accounts for an extra layer of security!" },
            { "2fa",              "Always enable Two-Factor Authentication (2FA) on your accounts for an extra layer of security!" },
            { "vpn",              "A VPN encrypts your internet connection. Use one especially when connecting to public Wi-Fi!" },
            { "firewall",         "A firewall monitors network traffic. Always keep it enabled to block unauthorized access!" },
            { "encryption",       "Encryption protects your data by converting it into unreadable code. Use encrypted apps for sensitive communication!" },
            { "backup",           "Always back up your data regularly. Use the 3-2-1 rule: 3 copies, 2 different media, 1 offsite!" },
            { "update",           "Always keep your software and OS updated. Updates patch security vulnerabilities!" },
            { "privacy",          "Protect your privacy by limiting what you share online and reviewing app permissions regularly!" },
            { "ransomware",       "Ransomware locks your files for payment. Always back up data and never open suspicious email attachments!" },
            { "hacker",           "Hackers exploit weak passwords and outdated software. Keep everything updated and use strong passwords!" },
            { "wifi",             "Avoid using public Wi-Fi for sensitive tasks. Always use a VPN if you must connect to public networks!" },
            { "email",            "Be careful with email attachments and links. Always verify the sender before clicking anything!" },
            { "identity theft",   "Protect your identity by monitoring your accounts, using strong passwords, and enabling 2FA!" },
            { "data breach",      "If your data is breached, change your passwords immediately and enable 2FA on all accounts!" },
            { "antivirus",        "Install reputable antivirus software and keep it updated to protect against the latest threats!" },
            { "bye",              "EXIT" },
            { "exit",             "EXIT" },
            { "quit",             "EXIT" }
        };

        public string GetResponse(string input)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(input))
                return "I didn't catch that. Could you rephrase?";

            // Check dictionary for exact key match first
            if (Responses.TryGetValue(input.Trim(), out string exactMatch))
                return exactMatch;

            // Check dictionary for keyword match inside input
            foreach (KeyValuePair<string, string> entry in Responses)
            {
                if (input.ToLower().Contains(entry.Key.ToLower()))
                    return entry.Value;
            }

            // Default
            return "I didn't quite understand that. Try asking about passwords, phishing, or safe browsing. Type 'list' to see all topics.";
        }
    }
}
