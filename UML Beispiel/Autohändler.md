# UML Klassendiagramm – Autohändler

## Oberthema: Autohändler

---

## Klassen

### 1. `Kunde`
> Repräsentiert Personen, die Autos kaufen oder reservieren möchten.

| Kategorie  | Name            |
|------------|-----------------|
| Attribut   | `Name`          |
| Attribut   | `Kundennummer`  |
| Attribut   | `Telefonnummer` |
| Methode    | `AutoKaufen()`      |
| Methode    | `AutoReservieren()` |

---

### 2. `Auto`
> Repräsentiert die Fahrzeuge im System.

| Kategorie  | Name                      |
|------------|---------------------------|
| Attribut   | `Marke`                   |
| Attribut   | `Modell`                  |
| Attribut   | `Preis`                   |
| Attribut   | `Baujahr`                 |
| Methode    | `Starten()`               |
| Methode    | `Stoppen()`               |
| Methode    | `InformationenAnzeigen()` |

---

### 3. `Autohändler`
> Repräsentiert den Händler, der Autos verkauft und verwaltet.

| Kategorie  | Name                   |
|------------|------------------------|
| Attribut   | `Name`                 |
| Attribut   | `Adresse`              |
| Attribut   | `AnzahlAutos`          |
| Methode    | `AutoHinzufügen()`     |
| Methode    | `AutoVerkaufen()`      |
| Methode    | `AutoListeAnzeigen()`  |

---

## Beziehungen zwischen den Klassen

| Von          | Zu           | Multiplizität        | Beschreibung                                                          |
|--------------|--------------|----------------------|-----------------------------------------------------------------------|
| `Kunde`      | `Auto`       | `1` ←→ `0..*`        | Ein Kunde kann mehrere Autos besitzen; ein Auto gehört genau einem Besitzer. |
| `Autohändler`| `Auto`       | `1` ←→ `0..*`        | Ein Händler kann mehrere Autos besitzen; ein Auto gehört genau einem Händler (vor dem Verkauf). |
| `Kunde`      | `Autohändler`| optional             | Ein Kunde interagiert mit einem Autohändler, um Autos zu kaufen oder zu reservieren. |

---

## UML Diagramm (Textdarstellung)

```
┌─────────────────────┐          ┌─────────────────────────┐
│       Kunde         │          │        Autohändler       │
├─────────────────────┤          ├─────────────────────────┤
│ - Name              │          │ - Name                  │
│ - Kundennummer      │          │ - Adresse               │
│ - Telefonnummer     │          │ - AnzahlAutos           │
├─────────────────────┤          ├─────────────────────────┤
│ + AutoKaufen()      │◄────────►│ + AutoHinzufügen()      │
│ + AutoReservieren() │ optional │ + AutoVerkaufen()       │
└─────────────────────┘          │ + AutoListeAnzeigen()   │
          │ 1                    └─────────────────────────┘
          │                                  │ 1
          │ besitzt                          │ verwaltet
          ▼ 0..*                             ▼ 0..*
┌─────────────────────────┐
│          Auto            │
├─────────────────────────┤
│ - Marke                 │
│ - Modell                │
│ - Preis                 │
│ - Baujahr               │
├─────────────────────────┤
│ + Starten()             │
│ + Stoppen()             │
│ + InformationenAnzeigen()│
└─────────────────────────┘
```
