import { Platform } from 'react-native';

export type ConversionCategory = 'length' | 'mass' | 'temperature';

export type LoginResponse = {
  success: boolean;
  message: string;
};

type RestLoginResponse = {
  isAuth: boolean;
  message: string;
};

export type ConversionResponse = {
  success: boolean;
  message: string;
  category: string;
  inputValue: number;
  fromUnit: string;
  toUnit: string;
  convertedValue: number;
};

type RestConversionResponse = {
  result: number;
  message: string;
};

const defaultBaseUrl = Platform.select({
  android: 'http://192.168.100.159:5110/api',
  default: 'http://localhost:5110/api',
}) as string;

const envBaseUrl = process.env.EXPO_PUBLIC_API_BASE_URL?.trim();
const rawBaseUrl = envBaseUrl && envBaseUrl.length > 0 ? envBaseUrl : defaultBaseUrl;

export const API_BASE_URL = rawBaseUrl.endsWith('/') ? rawBaseUrl.slice(0, -1) : rawBaseUrl;

let authenticatedSession = false;

async function postJson<T>(path: string, body: Record<string, unknown>): Promise<T> {
  const response = await fetch(`${API_BASE_URL}${path}`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
      Accept: 'application/json',
    },
    body: JSON.stringify(body),
  });

  const rawBody = await response.text();
  const json = rawBody ? (JSON.parse(rawBody) as T) : ({} as T);

  if (!response.ok) {
    throw new Error((json as { message?: string }).message ?? 'Request failed');
  }

  return json;
}

function toApiCategorySegment(category: ConversionCategory) {
  switch (category) {
    case 'length':
      return 'Length';
    case 'mass':
      return 'Mass';
    case 'temperature':
      return 'Temperature';
    default:
      return 'Length';
  }
}

function toApiUnit(category: ConversionCategory, unit: string) {
  if (category !== 'temperature') {
    return unit;
  }

  switch (unit.toLowerCase()) {
    case 'c':
      return 'C';
    case 'f':
      return 'F';
    case 'k':
      return 'K';
    case 'r':
    case 'ra':
      return 'Ra';
    case 're':
      return 'Re';
    default:
      return unit;
  }
}

function fromApiUnit(category: ConversionCategory, unit: string) {
  if (category !== 'temperature') {
    return unit;
  }

  switch (unit) {
    case 'C':
      return 'c';
    case 'F':
      return 'f';
    case 'K':
      return 'k';
    case 'Ra':
      return 'r';
    case 'Re':
      return 're';
    default:
      return unit.toLowerCase();
  }
}

export function login(username: string, password: string) {
  return postJson<RestLoginResponse>('/Auth/Login', { username, password }).then((response) => ({
    success: response.isAuth,
    message: response.message,
  }));
}

export function convert(category: ConversionCategory, value: number, fromUnit: string, toUnit: string) {
  const endpoint = `/UnitConversion/${toApiCategorySegment(category)}`;
  const normalizedFromUnit = toApiUnit(category, fromUnit);
  const normalizedToUnit = toApiUnit(category, toUnit);

  return postJson<RestConversionResponse>(endpoint, {
    value,
    from: normalizedFromUnit,
    to: normalizedToUnit,
  }).then((response) => ({
    success: true,
    message: response.message,
    category,
    inputValue: value,
    fromUnit: fromApiUnit(category, normalizedFromUnit),
    toUnit: fromApiUnit(category, normalizedToUnit),
    convertedValue: response.result,
  }));
}

export function setSessionAuthenticated(value: boolean) {
  authenticatedSession = value;
}

export function isSessionAuthenticated() {
  return authenticatedSession;
}

export function clearSession() {
  authenticatedSession = false;
}
