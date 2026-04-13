using System;
using System.Collections.Generic;

public class ResponseHandler
{
    private static Dictionary<string, string> responses = new Dictionary<string, string>()
    {
        {"how are you", "I'm just a bot, but I'm here to keep you safe online!"},
        {"purpose", "My purpose is to educate you about cybersecurity."},
        {"password", "Use strong passwords with numbers, symbols, and avoid sharing them."},
        {"phishing", "Be careful of suspicious emails and links. Always verify the sender."},
        {"safe browsing", "Always use secure websites (https) and avoid unknown downloads."},

        // PASSWORD SECURITY
        {"strong password", "A strong password should be at least 12 characters long."},
        {"password tips", "Use a mix of uppercase, lowercase, numbers, and symbols."},
        {"password reuse", "Never reuse passwords across multiple sites."},
        {"password manager", "Use a password manager to store your credentials safely."},
        {"change password", "Change your passwords regularly."},

        //  PHISHING
        {"email scam", "Do not click suspicious email links."},
        {"fake email", "Check sender email address carefully."},
        {"phishing attack", "Phishing tries to trick you into giving personal info."},
        {"spam email", "Avoid opening unknown attachments."},
        {"link safety", "Hover over links before clicking."},

        // INTERNET SAFETY
        {"https", "Always check for HTTPS in the URL."},
        {"public wifi", "Avoid sensitive transactions on public Wi-Fi."},
        {"vpn", "Use a VPN for extra privacy."},
        {"downloads", "Download only from trusted sources."},
        {"browser security", "Keep your browser updated."},

        //  MALWARE
        {"virus", "Install antivirus software to protect your system."},
        {"malware", "Malware can damage or steal your data."},
        {"trojan", "Trojans disguise themselves as legitimate software."},
        {"ransomware", "Ransomware locks your files until payment is made."},
        {"spyware", "Spyware secretly monitors your activity."},

        //  AUTHENTICATION
        {"2fa", "Enable two-factor authentication for extra security."},
        {"multi factor", "MFA adds another layer of protection."},
        {"authentication", "Always verify login attempts."},
        {"login alert", "Turn on login alerts for suspicious activity."},
        {"security code", "Never share your verification codes."},

        //  SOCIAL MEDIA SAFETY
        {"facebook security", "Review your privacy settings regularly."},
        {"instagram safety", "Avoid sharing personal info publicly."},
        {"social media", "Be cautious of fake profiles."},
        {"online friends", "Do not trust strangers online."},
        {"cyberbullying", "Report and block abusive users."},

        //  GENERAL SECURITY
        {"update software", "Keep your software updated to fix vulnerabilities."},
        {"backup data", "Always backup your important data."},
        {"firewall", "Enable your firewall for added protection."},
        {"device security", "Lock your device when not in use."},
        {"usb safety", "Avoid using unknown USB drives."},

        //  AWARENESS
        {"cybersecurity", "Cybersecurity protects systems and data from attacks."},
        {"hacker", "Hackers exploit weaknesses in systems."},
        {"data breach", "A data breach exposes confidential data."},
        {"privacy", "Protect your personal information online."},
        {"identity theft", "Never share personal details with strangers."},

        //  ONLINE BANKING
        {"banking", "Use official banking apps only."},
        {"otp", "Never share your OTP with anyone."},
        {"atm fraud", "Cover your PIN when using ATMs."},
        {"transaction alert", "Enable alerts for bank transactions."},
        {"secure payment", "Use trusted payment gateways."},

        //  EXTRA RESPONSES
        {"gaming safety", "Avoid sharing your gaming account details."},
        {"email password", "Do not store passwords in emails."},
        {"cloud security", "Use strong passwords for cloud accounts."},
        {"remote work", "Use secure connections when working remotely."},
        {"data protection", "Encrypt sensitive data whenever possible."}
    };

    public static string GetResponse(string input)
    {
        input = input.ToLower();

        foreach (var key in responses.Keys)
        {
            if (input.Contains(key))
            {
                return responses[key];
            }
        }

        if (input == "exit")
            return "Goodbye! Stay safe online ";

        return "I didn’t quite understand that. Could you rephrase?";
    }
}