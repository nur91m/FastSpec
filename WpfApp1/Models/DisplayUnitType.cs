﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecUI.Models
{
    public enum DisplayUnitType
    {
        DUT_UNDEFINED,
        DUT_CUSTOM,
        DUT_METERS,
        DUT_CENTIMETERS,
        DUT_MILLIMETERS,
        DUT_DECIMAL_FEET,
        DUT_FEET_FRACTIONAL_INCHES,
        DUT_FRACTIONAL_INCHES,
        DUT_DECIMAL_INCHES,
        DUT_ACRES,
        DUT_HECTARES,
        DUT_METERS_CENTIMETERS,
        DUT_CUBIC_YARDS,
        DUT_SQUARE_FEET,
        DUT_SQUARE_METERS,
        DUT_CUBIC_FEET,
        DUT_CUBIC_METERS,
        DUT_DECIMAL_DEGREES,
        DUT_DEGREES_AND_MINUTES,
        DUT_GENERAL,
        DUT_FIXED,
        DUT_PERCENTAGE,
        DUT_SQUARE_INCHES,
        DUT_SQUARE_CENTIMETERS,
        DUT_SQUARE_MILLIMETERS,
        DUT_CUBIC_INCHES,
        DUT_CUBIC_CENTIMETERS,
        DUT_CUBIC_MILLIMETERS,
        DUT_LITERS,
        DUT_GALLONS_US,
        DUT_KILOGRAMS_PER_CUBIC_METER,
        DUT_POUNDS_MASS_PER_CUBIC_FOOT,
        DUT_POUNDS_MASS_PER_CUBIC_INCH,
        DUT_BRITISH_THERMAL_UNITS,
        DUT_CALORIES,
        DUT_KILOCALORIES,
        DUT_JOULES,
        DUT_KILOWATT_HOURS,
        DUT_THERMS,
        DUT_INCHES_OF_WATER_PER_100FT,
        DUT_PASCALS_PER_METER,
        DUT_WATTS,
        DUT_KILOWATTS,
        DUT_BRITISH_THERMAL_UNITS_PER_SECOND,
        DUT_BRITISH_THERMAL_UNITS_PER_HOUR,
        DUT_CALORIES_PER_SECOND,
        DUT_KILOCALORIES_PER_SECOND,
        DUT_WATTS_PER_SQUARE_FOOT,
        DUT_WATTS_PER_SQUARE_METER,
        DUT_INCHES_OF_WATER,
        DUT_PASCALS,
        DUT_KILOPASCALS,
        DUT_MEGAPASCALS,
        DUT_POUNDS_FORCE_PER_SQUARE_INCH,
        DUT_INCHES_OF_MERCURY,
        DUT_MILLIMETERS_OF_MERCURY,
        DUT_ATMOSPHERES,
        DUT_BARS,
        DUT_FAHRENHEIT,
        DUT_CELSIUS,
        DUT_KELVIN,
        DUT_RANKINE,
        DUT_FEET_PER_MINUTE,
        DUT_METERS_PER_SECOND,
        DUT_CENTIMETERS_PER_MINUTE,
        DUT_CUBIC_FEET_PER_MINUTE,
        DUT_LITERS_PER_SECOND,
        DUT_CUBIC_METERS_PER_SECOND,
        DUT_CUBIC_METERS_PER_HOUR,
        DUT_GALLONS_US_PER_MINUTE,
        DUT_GALLONS_US_PER_HOUR,
        DUT_AMPERES,
        DUT_KILOAMPERES,
        DUT_MILLIAMPERES,
        DUT_VOLTS,
        DUT_KILOVOLTS,
        DUT_MILLIVOLTS,
        DUT_HERTZ,
        DUT_CYCLES_PER_SECOND,
        DUT_LUX,
        DUT_FOOTCANDLES,
        DUT_FOOTLAMBERTS,
        DUT_CANDELAS_PER_SQUARE_METER,
        DUT_CANDELAS,
        DUT_CANDLEPOWER,
        DUT_LUMENS,
        DUT_VOLT_AMPERES,
        DUT_KILOVOLT_AMPERES,
        DUT_HORSEPOWER,
        DUT_NEWTONS,
        DUT_DECANEWTONS,
        DUT_KILONEWTONS,
        DUT_MEGANEWTONS,
        DUT_KIPS,
        DUT_KILOGRAMS_FORCE,
        DUT_TONNES_FORCE,
        DUT_POUNDS_FORCE,
        DUT_NEWTONS_PER_METER,
        DUT_DECANEWTONS_PER_METER,
        DUT_KILONEWTONS_PER_METER,
        DUT_MEGANEWTONS_PER_METER,
        DUT_KIPS_PER_FOOT,
        DUT_KILOGRAMS_FORCE_PER_METER,
        DUT_TONNES_FORCE_PER_METER,
        DUT_POUNDS_FORCE_PER_FOOT,
        DUT_NEWTONS_PER_SQUARE_METER,
        DUT_DECANEWTONS_PER_SQUARE_METER,
        DUT_KILONEWTONS_PER_SQUARE_METER,
        DUT_MEGANEWTONS_PER_SQUARE_METER,
        DUT_KIPS_PER_SQUARE_FOOT,
        DUT_KILOGRAMS_FORCE_PER_SQUARE_METER,
        DUT_TONNES_FORCE_PER_SQUARE_METER,
        DUT_POUNDS_FORCE_PER_SQUARE_FOOT,
        DUT_NEWTON_METERS,
        DUT_DECANEWTON_METERS,
        DUT_KILONEWTON_METERS,
        DUT_MEGANEWTON_METERS,
        DUT_KIP_FEET,
        DUT_KILOGRAM_FORCE_METERS,
        DUT_TONNE_FORCE_METERS,
        DUT_POUND_FORCE_FEET,
        DUT_METERS_PER_KILONEWTON,
        DUT_FEET_PER_KIP,
        DUT_SQUARE_METERS_PER_KILONEWTON,
        DUT_SQUARE_FEET_PER_KIP,
        DUT_CUBIC_METERS_PER_KILONEWTON,
        DUT_CUBIC_FEET_PER_KIP,
        DUT_INV_KILONEWTONS,
        DUT_INV_KIPS,
        DUT_FEET_OF_WATER_PER_100FT,
        DUT_FEET_OF_WATER,
        DUT_PASCAL_SECONDS,
        DUT_POUNDS_MASS_PER_FOOT_SECOND,
        DUT_CENTIPOISES,
        DUT_FEET_PER_SECOND,
        DUT_KIPS_PER_SQUARE_INCH,
        DUT_KILONEWTONS_PER_CUBIC_METER,
        DUT_POUNDS_FORCE_PER_CUBIC_FOOT,
        DUT_KIPS_PER_CUBIC_INCH,
        DUT_INV_FAHRENHEIT,
        DUT_INV_CELSIUS,
        DUT_NEWTON_METERS_PER_METER,
        DUT_DECANEWTON_METERS_PER_METER,
        DUT_KILONEWTON_METERS_PER_METER,
        DUT_MEGANEWTON_METERS_PER_METER,
        DUT_KIP_FEET_PER_FOOT,
        DUT_KILOGRAM_FORCE_METERS_PER_METER,
        DUT_TONNE_FORCE_METERS_PER_METER,
        DUT_POUND_FORCE_FEET_PER_FOOT,
        DUT_POUNDS_MASS_PER_FOOT_HOUR,
        DUT_KIPS_PER_INCH,
        DUT_KIPS_PER_CUBIC_FOOT,
        DUT_KIP_FEET_PER_DEGREE,
        DUT_KILONEWTON_METERS_PER_DEGREE,
        DUT_KIP_FEET_PER_DEGREE_PER_FOOT,
        DUT_KILONEWTON_METERS_PER_DEGREE_PER_METER,
        DUT_WATTS_PER_SQUARE_METER_KELVIN,
        DUT_BRITISH_THERMAL_UNITS_PER_HOUR_SQUARE_FOOT_FAHRENHEIT,
        DUT_CUBIC_FEET_PER_MINUTE_SQUARE_FOOT,
        DUT_LITERS_PER_SECOND_SQUARE_METER,
        DUT_RATIO_10,
        DUT_RATIO_12,
        DUT_SLOPE_DEGREES,
        DUT_RISE_OVER_INCHES,
        DUT_RISE_OVER_FOOT,
        DUT_RISE_OVER_MMS,
        DUT_WATTS_PER_CUBIC_FOOT,
        DUT_WATTS_PER_CUBIC_METER,
        DUT_BRITISH_THERMAL_UNITS_PER_HOUR_SQUARE_FOOT,
        DUT_BRITISH_THERMAL_UNITS_PER_HOUR_CUBIC_FOOT,
        DUT_TON_OF_REFRIGERATION,
        DUT_CUBIC_FEET_PER_MINUTE_CUBIC_FOOT,
        DUT_LITERS_PER_SECOND_CUBIC_METER,
        DUT_CUBIC_FEET_PER_MINUTE_TON_OF_REFRIGERATION,
        DUT_LITERS_PER_SECOND_KILOWATTS,
        DUT_SQUARE_FEET_PER_TON_OF_REFRIGERATION,
        DUT_SQUARE_METERS_PER_KILOWATTS,
        DUT_CURRENCY,
        DUT_LUMENS_PER_WATT,
        DUT_SQUARE_FEET_PER_THOUSAND_BRITISH_THERMAL_UNITS_PER_HOUR,
        DUT_KILONEWTONS_PER_SQUARE_CENTIMETER,
        DUT_NEWTONS_PER_SQUARE_MILLIMETER,
        DUT_KILONEWTONS_PER_SQUARE_MILLIMETER,
        DUT_RISE_OVER_120_INCHES,
        DUT_1_RATIO,
        DUT_RISE_OVER_10_FEET,
        DUT_HOUR_SQUARE_FOOT_FAHRENHEIT_PER_BRITISH_THERMAL_UNIT,
        DUT_SQUARE_METER_KELVIN_PER_WATT,
        DUT_BRITISH_THERMAL_UNIT_PER_FAHRENHEIT,
        DUT_JOULES_PER_KELVIN,
        DUT_KILOJOULES_PER_KELVIN,
        DUT_KILOGRAMS_MASS,
        DUT_TONNES_MASS,
        DUT_POUNDS_MASS,
        DUT_METERS_PER_SECOND_SQUARED,
        DUT_KILOMETERS_PER_SECOND_SQUARED,
        DUT_INCHES_PER_SECOND_SQUARED,
        DUT_FEET_PER_SECOND_SQUARED,
        DUT_MILES_PER_SECOND_SQUARED,
        DUT_FEET_TO_THE_FOURTH_POWER,
        DUT_INCHES_TO_THE_FOURTH_POWER,
        DUT_MILLIMETERS_TO_THE_FOURTH_POWER,
        DUT_CENTIMETERS_TO_THE_FOURTH_POWER,
        DUT_METERS_TO_THE_FOURTH_POWER,
        DUT_FEET_TO_THE_SIXTH_POWER,
        DUT_INCHES_TO_THE_SIXTH_POWER,
        DUT_MILLIMETERS_TO_THE_SIXTH_POWER,
        DUT_CENTIMETERS_TO_THE_SIXTH_POWER,
        DUT_METERS_TO_THE_SIXTH_POWER,
        DUT_SQUARE_FEET_PER_FOOT,
        DUT_SQUARE_INCHES_PER_FOOT,
        DUT_SQUARE_MILLIMETERS_PER_METER,
        DUT_SQUARE_CENTIMETERS_PER_METER,
        DUT_SQUARE_METERS_PER_METER,
        DUT_KILOGRAMS_MASS_PER_METER,
        DUT_POUNDS_MASS_PER_FOOT,
        DUT_RADIANS,
        DUT_GRADS,
        DUT_RADIANS_PER_SECOND,
        DUT_MILISECONDS,
        DUT_SECONDS,
        DUT_MINUTES,
        DUT_HOURS,
        DUT_KILOMETERS_PER_HOUR,
        DUT_MILES_PER_HOUR,
        DUT_KILOJOULES,
        DUT_KILOGRAMS_MASS_PER_SQUARE_METER,
        DUT_POUNDS_MASS_PER_SQUARE_FOOT,
        DUT_WATTS_PER_METER_KELVIN,
        DUT_JOULES_PER_GRAM_CELSIUS,
        DUT_JOULES_PER_GRAM,
        DUT_NANOGRAMS_PER_PASCAL_SECOND_SQUARE_METER,
        DUT_OHM_METERS,
        DUT_BRITISH_THERMAL_UNITS_PER_HOUR_FOOT_FAHRENHEIT,
        DUT_BRITISH_THERMAL_UNITS_PER_POUND_FAHRENHEIT,
        DUT_BRITISH_THERMAL_UNITS_PER_POUND,
        DUT_GRAINS_PER_HOUR_SQUARE_FOOT_INCH_MERCURY,
        DUT_PER_MILLE,
        DUT_DECIMETERS,
        DUT_JOULES_PER_KILOGRAM_CELSIUS,
        DUT_MICROMETERS_PER_METER_CELSIUS,
        DUT_MICROINCHES_PER_INCH_FAHRENHEIT,
        DUT_USTONNES_MASS,
        DUT_USTONNES_FORCE
    }
}
