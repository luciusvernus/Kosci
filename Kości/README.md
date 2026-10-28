# Rozwiązanie arkusza INF.04-01-24.06-SG - Gra w kości (C# + .NET MAUI)

Pliki rozwiązania części praktycznej egzaminu zawodowego: arkusz **INF.04-01-24.06-SG**, kwalifikacja **INF.04 Projektowanie, programowanie i testowanie aplikacji**, sesja czerwiec 2024.

To jedno z możliwych rozwiązań. Egzaminator ocenia spełnienie kryteriów z klucza odpowiedzi, a nie zgodność z tym kodem - inna, poprawna droga też daje punkty.

## Skąd pobrane

https://zawodowe.edu.pl/arkusze-praktyczne/inf-04/inf04-2024-czerwiec-01/rozwiazanie/csharp-maui/

Tam jest wersja krok po kroku: wyjaśnienie, kod z podświetlonymi zmianami, podgląd strony i kryteria z klucza, za które są punkty.

## Dokumenty arkusza

- Strona arkusza: https://zawodowe.edu.pl/arkusze-praktyczne/inf-04/inf04-2024-czerwiec-01/
- Arkusz egzaminacyjny (PDF): https://zawodowe.edu.pl/arkusz-praktyczny/inf04-2024-czerwiec-01/arkusz.pdf
- Zasady oceniania - klucz (PDF): https://zawodowe.edu.pl/arkusz-praktyczny/inf04-2024-czerwiec-01/klucz-odpowiedzi.pdf
- Załącznik z plikami do zadania (pliki1.zip): https://zawodowe.edu.pl/arkusz-praktyczny/inf04-2024-czerwiec-01/zalacznik/45/pliki1.zip
- Kwalifikacja INF.04: https://zawodowe.edu.pl/kwalifikacje-w-zawodzie/inf-04/
- Wszystkie rozwiązania INF.04: https://zawodowe.edu.pl/arkusze-praktyczne/inf-04/rozwiazania/

## Zawartość archiwum

Wszystko leży w folderze `inf04-2024-czerwiec-01/`. Na egzaminie ten folder nazywa się numerem zdającego.

- `Kosci/MainPage.xaml` - układ okna (XAML)
- `Kosci/MainPage.xaml.cs` - kod C#
- `egzamin.txt` - plik projektu
- `konsola/Program.cs` - kod C#
- `Kosci/Resources/Images/k1.jpg` - grafika z załącznika arkusza
- `Kosci/Resources/Images/k2.jpg` - grafika z załącznika arkusza
- `Kosci/Resources/Images/k3.jpg` - grafika z załącznika arkusza
- `Kosci/Resources/Images/k4.jpg` - grafika z załącznika arkusza
- `Kosci/Resources/Images/k5.jpg` - grafika z załącznika arkusza
- `Kosci/Resources/Images/k6.jpg` - grafika z załącznika arkusza
- `Kosci/Resources/Images/question.jpg` - grafika z załącznika arkusza

## Jak uruchomić

**Aplikacja konsolowa** (folder `konsola`): `dotnet run` w folderze projektu albo `konsola.csproj` w Visual Studio (.NET 8 lub nowszy).

**Aplikacja mobilna** (folder `Kosci`): w Visual Studio utwórz projekt **Aplikacja .NET MAUI** (`dotnet new maui -n Kosci`), podmień `MainPage.xaml` i `MainPage.xaml.cs` na pliki z archiwum, skopiuj obrazy do `Resources/Images` i uruchom na emulatorze Androida (*Android Emulators* → Pixel). Z terminala: `dotnet build -t:Run -f net10.0-android` (w projekcie .NET 8: `net8.0-android`).

## Autor i licencja

Rozwiązanie: Bartosz Bryniarski, zawodowe.edu.pl, opublikowane 09.10.2026.

Licencja: [CC BY-NC 4.0](https://creativecommons.org/licenses/by-nc/4.0/deed.pl) - kopiowanie i przeróbki do celów niekomercyjnych, z podaniem autora i źródła: https://zawodowe.edu.pl/arkusze-praktyczne/inf-04/inf04-2024-czerwiec-01/rozwiazanie/csharp-maui/

Przerobiony materiał oznacz przy podpisie, np. „Materiał zmodyfikowany.”

Co wolno uczniowi, nauczycielowi, szkole i innym - zwykłym językiem: https://zawodowe.edu.pl/arkusze-praktyczne/rozwiazania/zasady/

Treść arkusza i klucza oceniania pochodzi z CKE. Rozwiązanie jest materiałem edukacyjnym serwisu https://zawodowe.edu.pl/
