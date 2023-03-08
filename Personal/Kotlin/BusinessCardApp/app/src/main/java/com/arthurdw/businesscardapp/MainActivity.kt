package com.arthurdw.businesscardapp

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.Image
import androidx.compose.foundation.layout.*
import androidx.compose.material.Icon
import androidx.compose.material.MaterialTheme
import androidx.compose.material.Surface
import androidx.compose.material.Text
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.rounded.Email
import androidx.compose.material.icons.rounded.Favorite
import androidx.compose.material.icons.rounded.Send
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.graphics.vector.ImageVector
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.res.stringResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.arthurdw.businesscardapp.ui.theme.BusinessCardAppTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            BusinessCardAppTheme {
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
    Column(modifier = modifier, verticalArrangement = Arrangement.SpaceBetween) {
        Box(modifier = modifier.fillMaxHeight().weight(1f), contentAlignment = Alignment.Center) { Main() }
        Footer()
    }
}

@Composable
fun Main(modifier: Modifier = Modifier) {
    val image = painterResource(id = R.drawable.android_logo)

    Column(
        modifier = modifier.fillMaxWidth(),
        horizontalAlignment = Alignment.CenterHorizontally,
        verticalArrangement = Arrangement.Center
    ) {
        Image(painter = image, contentDescription = null, modifier = modifier.width(100.dp).padding(bottom = 12.dp))
        Text(text = stringResource(R.string.author), fontSize = 24.sp, color = Color.White)
        Text(text = stringResource(R.string.title), fontSize = 18.sp, color = Color(0xFF3ddc84), fontWeight = FontWeight.Bold)
    }
}

@Composable
fun Footer(modifier: Modifier = Modifier) {
    Column(modifier = modifier.fillMaxWidth(), horizontalAlignment = Alignment.CenterHorizontally) {
        Column(modifier = modifier.padding(bottom = 50.dp)) {
            FooterItem(icon = Icons.Rounded.Email, text = stringResource(R.string.contact))
            FooterItem(icon = Icons.Rounded.Send, text = stringResource(R.string.message))
            FooterItem(icon = Icons.Rounded.Favorite, text = stringResource(R.string.made_with))
        }
    }
}

@Composable
fun FooterItem(icon: ImageVector, text: String, modifier: Modifier = Modifier) {
    Row(modifier = modifier.padding(8.dp), horizontalArrangement = Arrangement.Center) {
        Icon(
            imageVector = icon,
            contentDescription = null,
            tint = Color(0xFF3ddc84),
            modifier = modifier.padding(end = 16.dp)
        )
        Text(text = text, color = Color.White)
    }
}


@Preview(showBackground = true)
@Composable
fun DefaultPreview() {
    BusinessCardAppTheme {
        Surface(color = Color(0xFF073042)) {
            Application()
        }
    }
}