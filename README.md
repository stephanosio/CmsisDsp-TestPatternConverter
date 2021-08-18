## CMSIS (DSP, NN) Test Pattern Converter

The CMSIS Test Pattern Converter (CmsisTestPatternConverter) utility converts the automatically generated test pattern text files included in the official CMSIS distribution (ARM-software/CMSIS_5/CMSIS/DSP/Testing/Patterns) to the C array files used by the Zephyr RTOS test suite.

### Usage

#### Convert all test patterns
```
./CmsisTestPatternConverter.exe \
  -c "zephyr-public/zephyr/tests/lib/cmsis_dsp" \
  -p "CMSIS_5/CMSIS/DSP/Testing/Patterns/DSP"
```

#### Convert specific tests
```
./CmsisTestPatternConverter.exe \
  -c "zephyr-public/zephyr/tests/lib/cmsis_dsp" \
  -p "CMSIS_5/CMSIS/DSP/Testing/Patterns/DSP" \
  -t "transform/src/q31.c" "transform/src/q15.c"
```

### Notes

- This utility is supported on both Windows and Linux (macOS should work too, but is not tested).
- Mono Runtime is required to run this utility on Linux (tested with Mono 6.6.0.161).
