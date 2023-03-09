package com.arthurdw.introtostateincompose

import org.junit.Assert.assertEquals
import org.junit.Test
import java.text.NumberFormat

class TipCalculatorTests {
    @Test
    fun calculate_20_percent_tip_no_roundup() {
        val amount = 100.0
        val tipPercent = 20.0
        val roundUp = false
        val expectedTip = NumberFormat.getCurrencyInstance().format(20.0)

        val tip = calculateTip(amount, tipPercent, roundUp)
        assertEquals(expectedTip, tip)
    }
}