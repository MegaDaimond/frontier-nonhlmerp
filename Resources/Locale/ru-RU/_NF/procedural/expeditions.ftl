salvage-expedition-window-finish = Завершить экспедицию
salvage-expedition-announcement-early-finish = Экспедиция завершилась раньше запланированного срока. Шаттл отправится через { $departTime } секунд.
salvage-expedition-announcement-destruction =
    { $count ->
        [1] Уничтожьте { $structure } до того как экспедиция закончится.
       *[others] Уничтожьте { $count } { $structure } до того как экспедиция закончится.
    }
salvage-expedition-announcement-elimination =
    { $count ->
        [1] Убейте { $target } до того как экспедиция закончится.
       *[others] Убейте { $count } { $target } до того как экспедиция закончится.
    }
salvage-expedition-announcement-destruction-entity-fallback = структура
salvage-expedition-announcement-elimination-entity-fallback = цель
salvage-expedition-shuttle-not-found = Нет возможности найти шаттл.
salvage-expedition-not-everyone-aboard = Не весь экипаж на борту! { CAPITALIZE($target) } все ещё там!
# Salvage mods
salvage-time-mod-standard-time = Нормальная продолжительность
salvage-time-mod-rush = Штурм
salvage-weather-mod-heavy-snowfall = Тяжёлый снегопад
salvage-weather-mod-rain = Дождь
salvage-biome-mod-shadow = Тени
salvage-dungeon-mod-cave-factory = Пещерная фабрика
salvage-dungeon-mod-med-sci = Научно-медицинская база
salvage-dungeon-mod-factory-dorms = Заводские общежития
salvage-dungeon-mod-lava-mercenary = Лавовая база наёмников
salvage-dungeon-mod-virology-lab = Лаборатория вирусологии
salvage-dungeon-mod-salvage-outpost = Аванпост утилизаторов
salvage-air-mod-1 = 82 N2, 21 O2
salvage-air-mod-2 = 72 N2, 21 O2, 10 N2O
salvage-air-mod-3 = 72 N2, 21 O2, 10 H2O
salvage-air-mod-4 = 72 N2, 21 O2, 10 NH3
salvage-air-mod-5 = 72 N2, 21 O2, 10 CO2
salvage-air-mod-6 = 79 N2, 21 O2, 5 P
salvage-air-mod-7 = 57 N2, 21 O2, 15 NH3, 5 P, 5 N2O
salvage-air-mod-8 = 57 N2, 21 O2, 15 H2O, 5 NH3, 5 N2O
salvage-air-mod-9 = 57 N2, 21 O2, 15 CO2, 5 P, 5 N2O
salvage-air-mod-10 = 82 CO2, 21 O2
salvage-air-mod-11 = 67 CO2, 31 O2, 5 P
salvage-air-mod-12 = 103 H2O
salvage-air-mod-13 = 103 NH3
salvage-air-mod-14 = 103 N2O
salvage-air-mod-15 = 103 CO2
salvage-air-mod-16 = 34 CO2, 34 NH3, 34 N2O
salvage-air-mod-17 = 34 H2O, 34 NH3, 34 N2O
salvage-air-mod-18 = 34 H2O, 34 N2O, 17 NH3, 17 CO2
salvage-air-mod-unknown = Неизвестная атмосфера
salvage-expedition-difficulty-NFModerate = Средняя
salvage-expedition-difficulty-NFHazardous = Сложная
salvage-expedition-difficulty-NFExtreme = Экстрим
salvage-expedition-megafauna-remaining =
    { $count ->
        [one] { $count } цель осталась.
       *[other] { $count } целей осталось.
    }
salvage-expedition-type-Destruction = Уничтожение
salvage-expedition-type-Elimination = Убийство
