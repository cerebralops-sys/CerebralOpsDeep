# DeepExecutive

ASP.NET Core 8 executive profile website for Deepkumar Janardhanan.

## Positioning

**Technology Executive with Marketing Mastery**

Target leadership mandates include VP Marketing / Head of Marketing, VP Technology, Global Technology Delivery, Transformation & Operations, and Fractional / Interim Executive Leadership.

## Stack

- ASP.NET Core 8 MVC
- C#
- Razor views
- Static CSS
- No database dependency

## Run locally

```bash
dotnet restore
dotnet run
```

The application is designed for .NET 8.

## Content structure

- Home — executive positioning and selected evidence
- Profile — leadership background, industries and international experience
- Experience — career scope and outcomes
- Case Studies — selected evidence summaries
- Capabilities — marketing, technology, delivery and transformation capabilities
- Resume — role-specific downloadable resumes
- Contact — executive opportunities and fractional/interim pathway

## Production notes

- Replace the static sitemap paths with the production domain when deployed.
- Configure the production HTTPS certificate and hosting environment.
- Keep role-specific PDF resumes in `wwwroot/documents`.
