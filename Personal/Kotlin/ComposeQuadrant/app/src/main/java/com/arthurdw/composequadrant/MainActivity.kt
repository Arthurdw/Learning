package com.arthurdw.composequadrant

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.*
import androidx.compose.material.MaterialTheme
import androidx.compose.material.Surface
import androidx.compose.material.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.res.stringResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import com.arthurdw.composequadrant.ui.theme.ComposeQuadrantTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            ComposeQuadrantTheme {
                Surface(
                    modifier = Modifier.fillMaxSize(), color = MaterialTheme.colors.background
                ) {
                    Application()
                }
            }
        }
    }
}

@Composable
fun Application(modifier: Modifier = Modifier) {
    Column(modifier = modifier.fillMaxWidth()) {
        Row(modifier = modifier.weight(1f)) {
            Part(
                color = Color.Green,
                title = stringResource(R.string.text_title),
                description = stringResource(R.string.text_description),
                modifier = modifier.weight(1f)
            )
            Part(
                color = Color.Yellow,
                title = stringResource(R.string.image_title),
                description = stringResource(R.string.image_description),
                modifier = modifier.weight(1f)
            )
        }
        Row(modifier = modifier.weight(1f)) {
            Part(
                color = Color.Cyan,
                title = stringResource(R.string.row_title),
                description = stringResource(R.string.row_description),
                modifier = modifier.weight(1f)
            )
            Part(
                color = Color.LightGray,
                title = stringResource(R.string.column_title),
                description = stringResource(R.string.column_description),
                modifier = modifier.weight(1f)
            )
        }
    }
}

@Composable
fun Part(color: Color, title: String, description: String, modifier: Modifier = Modifier) {
    Column(
        modifier = modifier
            .fillMaxSize()
            .background(color)
            .padding(16.dp),
        verticalArrangement = Arrangement.Center,
        horizontalAlignment = Alignment.CenterHorizontally
    ) {
        Text(
            text = title,
            fontWeight = FontWeight.Bold,
        )
        Text(text = description, textAlign = TextAlign.Justify)
    }
}

@Preview(showBackground = true)
@Composable
fun DefaultPreview() {
    ComposeQuadrantTheme {
        Application()
    }
}